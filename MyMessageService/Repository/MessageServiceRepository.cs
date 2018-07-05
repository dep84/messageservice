using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using MyMessageService.Model;

namespace MyMessageService.Repository
{
    public class MessageServiceRepository
    {
        private readonly CloudTableClient tableClient;
        private readonly CloudTable messageTable;

        public MessageServiceRepository(TableStorageSettings tableStorageSettings)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(tableStorageSettings.ConnectionString);
            tableClient = storageAccount.CreateCloudTableClient();
            messageTable = tableClient.GetTableReference("messageTable");
            messageTable.CreateIfNotExistsAsync();       


            MessageItem message1 = new MessageItem("hej");
            message1.MessageSubject = "Hej";
            message1.MessageBody = "detta är en text";

            TableOperation insertOperation = TableOperation.Insert(message1);

        }
    }
}
