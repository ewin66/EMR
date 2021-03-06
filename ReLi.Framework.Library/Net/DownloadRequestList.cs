﻿namespace ReLi.Framework.Library.Net
{
    #region Using Declarations

    using System;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using ReLi.Framework.Library;
    using ReLi.Framework.Library.IO;
    using ReLi.Framework.Library.Collections;
    using ReLi.Framework.Library.Threading;
    using ReLi.Framework.Library.Serialization;

    #endregion
        
	public class DownloadRequestList : ObjectListBase<DownloadRequest>
    {
         public DownloadRequestList()
            : base()
        {}

        public DownloadRequestList(IEnumerable<DownloadRequest> objDownloadRequests)
            : base(objDownloadRequests)
        {}

        public DownloadRequestList(SerializedObject objSerializedObject)
            : base(objSerializedObject)
        {}

        public DownloadRequestList(BinaryReaderExtension objBinaryReader)
            : base(objBinaryReader)
        {}

        public IEnumerable<ITask> GetTasks()
        {
            List<ITask> objTasks = new List<ITask>();
            foreach (DownloadRequest objDownloadRequest in this)
            {
                objTasks.Add(objDownloadRequest);
            }

            return objTasks.ToArray();
        }

        #region SerializableObject Members

        public override void WriteData(SerializedObject objSerializedObject)
        {
            base.WriteData(objSerializedObject);
        }

        public override void ReadData(SerializedObject objSerializedObject)
        {
            base.ReadData(objSerializedObject);
        }

        #endregion

        #region TransportableObject Members

        public override void WriteData(BinaryWriterExtension objBinaryWriter)
        {
            base.WriteData(objBinaryWriter);
        }

        public override void ReadData(BinaryReaderExtension objBinaryReader)
        {
            base.ReadData(objBinaryReader);
        }

        #endregion

    }
}
