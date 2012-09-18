using System;
using DevExpress.Xpo;

namespace SSTCP.Database
{

    public class Cards : XPObject
    {
        public string CardModel;
        public string CardRevision;
        public Int32 CardSerialNumber;
        public string CardName;
        [Size(SizeAttribute.Unlimited)]
        public string CardDescription;
        public bool CardConnected;

        public Cards()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Cards(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}