using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Drive.v2;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Services;
using Google.Apis.Drive.v2.Data;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace ProdanBackup
{
    public static class GoogleDrive
    {
        public static object Autentica()
        {
            try
            {
                //Scopes for use with the Google Drive API
                string[] scopes = new string[] { DriveService.Scope.Drive,
                                 DriveService.Scope.DriveFile};
                var clientId = "1058227772343-e6b8h7fsfkno4aslnsqsrefu10mr1ltt.apps.googleusercontent.com";      // From https://console.developers.google.com
                var clientSecret = "_lQA0JcdpTFRSH8o7jyeOe-7";          // From https://console.developers.google.com
                string user = Environment.UserName;
                string AppData = Environment.ExpandEnvironmentVariables("%AppData%");
        
                if (!System.IO.File.Exists(AppData + "\\Prodan.GoogleDrive.Auth.Store\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-" + user))
                {
                    MessageBox.Show("Este aplicativo requer acesso à sua conta no Google.\n\nNa página que abrir, faça login se necessário e autorize o aplicativo.", "Login Google", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                // here is where we Request the user to give us access, or use the Refresh Token that was previously stored in %AppData%
                var credencial = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret

                },
                                                                            scopes,
                                                                            user,
                                                                            CancellationToken.None,
                                                                            new FileDataStore("Prodan.GoogleDrive.Auth.Store")).Result;
                
                return credencial;
            }
            catch (Exception excp)
            {
                MessageBox.Show("Não rolou química\n" + excp.Message);
                return false;
            }
        }

        // tries to figure out the mime type of the file.
        private static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }

        public static File uploadFile(DriveService _service, string _uploadFile, string _parent)
        {

            if (System.IO.File.Exists(_uploadFile))
            {
                File body = new File();
                body.Title = System.IO.Path.GetFileName(_uploadFile);
                body.Description = "File uploaded by Diamto Drive Sample";
                body.MimeType = GetMimeType(_uploadFile);
                body.Parents = new List<ParentReference>() { new ParentReference() { Id = _parent } };

                // File's content.
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    FilesResource.InsertMediaUpload request = _service.Files.Insert(body, stream, GetMimeType(_uploadFile));
                    File file = request.ResponseBody;
                    request.Upload();
                    //MessageBox.Show(body.Title+" "+body.MimeType+" "+file.ToString());
                    return file;
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error occurred: " + e.Message);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("File does not exist: " + _uploadFile);
                return null;
            }

        }

        public static List<File> retrieveAllFiles(DriveService _service)
        {
            
            List<File> result = new List<File>();

            FilesResource.ListRequest request = _service.Files.List();

            do
            {
                try
                {
                    FileList files = request.Execute();

                    result.AddRange(files.Items);
                    request.PageToken = files.NextPageToken;
                    //MessageBox.Show(files.Items.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error occurred: " + e.Message);
                    request.PageToken = null;
                }
            } while (!String.IsNullOrEmpty(request.PageToken));
            return result;
        }

        public static Boolean downloadFile(DriveService _service, File _fileResource, string _saveTo)
        {

            if (!String.IsNullOrEmpty(_fileResource.DownloadUrl))
            {
                try
                {
                    var x = _service.HttpClient.GetByteArrayAsync(_fileResource.DownloadUrl);
                    byte[] arrBytes = x.Result;
                    System.IO.File.WriteAllBytes(_saveTo, arrBytes);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("DEU PAU!: " + e.Message);
                    return false;
                }
            }
            else
            {
                // The file doesn't have any content stored on Drive.
                return false;
            }
        }

        public static File updateFile(DriveService _service, string _uploadFile, string _parent, string _fileId)
        {

            if (System.IO.File.Exists(_uploadFile))
            {
                File body = new File();
                body.Title = System.IO.Path.GetFileName(_uploadFile);
                body.Description = "File updated by Diamto Drive Sample";
                body.MimeType = GetMimeType(_uploadFile);
                body.Parents = new List<ParentReference>() { new ParentReference() { Id = _parent } };

                // File's content.
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);
                try
                {
                    FilesResource.UpdateMediaUpload request = _service.Files.Update(body, _fileId, stream, GetMimeType(_uploadFile));
                    request.Upload();
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error occurred: " + e.Message);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("File does not exist: " + _uploadFile);
                return null;
            }

        }

        public static File deleteFile(DriveService _service, File file)
        {
                              
            try
            {
                FilesResource.DeleteRequest DeleteRequest = _service.Files.Delete(file.Id);
                DeleteRequest.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return null;
            }
            return null;
                        
        }

        public static File createDirectory(DriveService _service, string _title, string _description, string _parent)
        {

            File NewDirectory = null;

            // Create metaData for a new Directory
            File body = new File();
            body.Title = _title;
            body.Description = _description;
            body.MimeType = "application/vnd.google-apps.folder";
            body.Parents = new List<ParentReference>() { new ParentReference() { Id = _parent } };
            try
            {
                FilesResource.InsertRequest request = _service.Files.Insert(body);
                NewDirectory = request.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

            return NewDirectory;
        }

        public static ChildList PrintFilesInFolder(DriveService service, String folderId) 
        {

            ChildrenResource.ListRequest request = service.Children.List(folderId);
            do 
            {
                try
                {
                    ChildList children = request.Execute();

                    //foreach (ChildReference child in children.Items) 
                    //{
                    //    Console.WriteLine("File Id: " + child.Id);
                    //}
                    request.PageToken = children.NextPageToken;
                    return children;
                }
                catch (Exception e) 
                {
                    MessageBox.Show("DEU PAU! " + e.Message);
                    request.PageToken = null;
                    return null;
                }
            } 
            while (!String.IsNullOrEmpty(request.PageToken));
        }

        public static byte[] LeRequest(Google.Apis.Drive.v2.Data.File Arquivo)
        {
            var credential = GoogleDrive.Autentica() as Google.Apis.Http.IConfigurableHttpClientInitializer;
            var _service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Backup"
            });
            var x = _service.HttpClient.GetByteArrayAsync(Arquivo.DownloadUrl);
            byte[] arrBytes = x.Result;
            return arrBytes;
        }


  
    }//classe
}//namespace
