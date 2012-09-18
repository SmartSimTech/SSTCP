using System;
using DevExpress.Xpo;

namespace SSTCP.Database
{

    public class AnalogOutputScripts : XPObject
    {
        public String Offset;
        public int Bit;
        public int Length;
        [Size(SizeAttribute.Unlimited)]
        public string OutputCode;
        public Int32 CardSerial;
        public string CardRevision;
        public string CardModel;

        public AnalogOutputScripts() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public AnalogOutputScripts(Session session) : base(session)
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