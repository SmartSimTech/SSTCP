using System;
using DevExpress.Xpo;

namespace SSTCP.Database { 
	
	public class AnalogInputConfiguration : XPObject {
        public Int32 Input;
        public String InputName;
        public bool InputStatus;
        [Size(SizeAttribute.Unlimited)]
        public string CodeButtonUp;
        [Size(SizeAttribute.Unlimited)]
        public string CodeButtonDown;
        [Size(SizeAttribute.Unlimited)]
        public string InputDescription;
        public Int32 CardSerial;
        public string CardRevision;
        public string CardModel;
        public bool InputEnabled;
		public AnalogInputConfiguration() : base() {
			// This constructor is used when an object is loaded from a persistent storage.
			// Do not place any code here.
		}

		public AnalogInputConfiguration(Session session) : base(session) {
			// This constructor is used when an object is loaded from a persistent storage.
			// Do not place any code here.
		}

		public override void AfterConstruction() { 
			base.AfterConstruction(); 
			// Place here your initialization code.
		}
	}

}