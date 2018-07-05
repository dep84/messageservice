using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace MyMessageService.Model
{
    public class MessageItem : TableEntity
    {
        public MessageItem(string senderId)
        {
            this.PartitionKey = Guid.NewGuid().ToString();
            this.RowKey = senderId;
        }

        public MessageItem() { }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }

    }
}
