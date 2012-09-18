using System;
using DevExpress.Xpo;

namespace SSTCP.Database {

    public class AnalogOutputConfiguration : XPObject {
        public Int32 Output;
        public String OutputName;
        public bool OutputStatus;
        [Size(SizeAttribute.Unlimited)]
        public string OutputDescription;
        public Int32 CardSerial;
        public string CardRevision;
        public string CardModel;
    
		public AnalogOutputConfiguration() : base() {
			// This constructor is used when an object is loaded from a persistent storage.
			// Do not place any code here.
		}

		public AnalogOutputConfiguration(Session session) : base(session) {
			// This constructor is used when an object is loaded from a persistent storage.
			// Do not place any code here.
		}

		public override void AfterConstruction() { 
			base.AfterConstruction(); 
			// Place here your initialization code.
		}
	}

}