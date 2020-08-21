using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace media_organizer_app.Services {
	public class DataManager {

	}

	public class FileIndexItem {
		public string path { get; set; }
		public string type { get; set; }
		public List<object> metadata { get; set; }
	}
}
