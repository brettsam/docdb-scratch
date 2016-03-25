using System;
using System.Linq;
using Microsoft.Azure.Documents.Client;
using NHClientTest;

namespace DocDBScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            var docDBclient = new DocumentClient(new Uri("yoururl"), "yourkey");

            var collUri = UriFactory.CreateDocumentCollectionUri("ItemDb", "ItemCollection");
            var results = docDBclient.CreateDocumentQuery<Doc>(collUri).AsEnumerable().ToList();

            // do whatever you want here to find min, max, count, etc
        }
    }
}
