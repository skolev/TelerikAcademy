using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Services.Client;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;

namespace UploadToAzureStorage
{
    public class Program
    {
        private static CloudStorageAccount storageAccount = null;
        private static string connectionString = "UseDevelopmentStorage=true";
        private static string containerName = "assemblies";
        private static string fileLocation = @"..\..\..\Bookstore.Models\bin\Debug\Bookstore.Models.dll";

        private static void Main()
        {
            while (true)
            {
                PrintOptions();

                int option = int.Parse(Console.ReadLine());

                storageAccount = CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings["Storage"].ConnectionString);

                // Create the blob client.
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

                // Retrieve a reference to a container that we wantto use
                CloudBlobContainer container = blobClient.GetContainerReference(containerName);

                // Create the container if it doesn't already exist.
                container.CreateIfNotExists();

                string blobName = fileLocation.Substring(fileLocation.LastIndexOf('\\') + 1);

                switch (option)
                {
                    case 1:
                        UploadBlob(container, blobName);
                        break;
                    case 2:
                        ListData(container);
                        break;
                    case 3:
                        GetInfo();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintOptions()
        {
            Console.WriteLine("Please select the option:");
            Console.WriteLine("1 - Upload blob");
            Console.WriteLine("2 - List storage blobs");
            Console.WriteLine("3 - Properties metadata");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");
        }

        private static void UploadBlob(CloudBlobContainer container, string blobName)
        {
            try
            {
                // Retrieve reference to a blob
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);

                using (var fileStream = System.IO.File.OpenRead(fileLocation))
                {
                    blockBlob.UploadFromStream(fileStream);
                }

                ConfirmContinuation();
            }
            catch
            {
                throw new Exception("Failed to upload.");
            }
        }

        private static void ListData(CloudBlobContainer container)
        {
            try
            {
                // Loop over items within the container and output the length and URI.
                foreach (IListBlobItem item in container.ListBlobs(null, false))
                {
                    if (item.GetType() == typeof(CloudBlockBlob))
                    {
                        CloudBlockBlob blob = (CloudBlockBlob)item;

                        Console.WriteLine("Block blob of length {0}: {1}", blob.Properties.Length, blob.Uri);
                    }

                    else
                    {
                        Console.WriteLine("No blobs found");
                    }
                }

                ConfirmContinuation();
            }
            catch
            {
                throw new Exception("Failed to retrieve list.");
            }
        }

        private static void GetInfo()
        {
            Assembly assembly = Assembly.LoadFrom(fileLocation);
            var pubTypesQuery = assembly.GetTypes();

            foreach (var item in pubTypesQuery)
            {

                Console.WriteLine("Class: {0}", item.Name);

                foreach (PropertyInfo propertyInfo in item.GetProperties())
                {
                    Console.WriteLine("  {0} - {1}", propertyInfo.Name, propertyInfo.PropertyType);
                    IEnumerable<CustomAttributeData> attributes = propertyInfo.CustomAttributes;
                    if (attributes.Count() != 0)
                    {
                        foreach (var attribute in attributes)
                        {
                            Console.WriteLine("   Custom attributes: {0}", attribute.ToString());
                        };
                    }
                }
            }

            ConfirmContinuation();
        }

        private static void ConfirmContinuation()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
