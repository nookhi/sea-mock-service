using System;
using System.ServiceModel;
using System.ServiceModel.Description;

class Program
{
    static void Main()
    {
        Uri baseAddress = new Uri("http://localhost:80/DocumentService");

        using (ServiceHost host = new ServiceHost(typeof(DocumentService), baseAddress))
        {
            var binding = new BasicHttpBinding();
            host.AddServiceEndpoint(typeof(IDocumentServicePort), binding, "");

            // Включаем метаданные для WSDL
            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);

            host.Open();

            Console.WriteLine("SOAP Mock Service is running...");
            Console.WriteLine("Access WSDL at: " + baseAddress + "?wsdl");
            Console.WriteLine("Press ENTER to stop.");
            Console.ReadLine();
        }
    }
}
