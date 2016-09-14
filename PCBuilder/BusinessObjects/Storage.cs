/*
 * OBJECT FINALIZED
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Storage object to hold necessary data on the storage device.
    /// </summary>
    public class Storage
    {
        public int StorageId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int StorageSize { get; set; }
        public string StorageType { get; set; }
        public int BenchmarkScore { get; set; }
        public int StorageSequentialRead { get; set; }
        public int StorageSequentialWrite { get; set; }
        public int StorageRandomRead { get; set; }
        public int StorageRandomWrite { get; set; }
        public string BestUse { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Storage"/> class.
        /// </summary>
        public Storage() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Storage"/> class.
        /// </summary>
        /// <param name="storageId">The storage identifier.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="model">The model.</param>
        /// <param name="storageSize">Size of the storage.</param>
        /// <param name="storageType">Type of the storage.</param>
        /// <param name="benchmarkScore">The benchmark score.</param>
        /// <param name="storageSequentialRead">The storage sequential read.</param>
        /// <param name="storageSequentialWrite">The storage sequential write.</param>
        /// <param name="storageRandomRead">The storage random read.</param>
        /// <param name="storageRandomWrite">The storage random write.</param>
        /// <param name="bestUse">The best use case.</param>
        /// <param name="price">The price.</param>
        public Storage (int storageId,
                        string brand,
                        string model,
                        int storageSize,
                        string storageType,
                        int benchmarkScore,
                        int storageSequentialRead,
                        int storageSequentialWrite,
                        int storageRandomRead,
                        int storageRandomWrite,
                        string bestUse,
                        decimal price)
        {
            StorageId = storageId;
            Brand = brand;
            Model = model;
            StorageSize = storageSize;
            StorageType = storageType;
            BenchmarkScore = benchmarkScore;
            StorageSequentialRead = storageSequentialRead;
            StorageSequentialWrite = storageSequentialWrite;
            StorageRandomRead = storageRandomRead;
            StorageRandomWrite = storageRandomWrite;
            BestUse = bestUse;
            Price = price;
        }
    }
}
