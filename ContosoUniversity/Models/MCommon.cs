using System;
using System.Collections.Generic;
namespace ContosoUniversity.Models
{
	public class MCommon<T>
	{
		public List<T> Data { get; set; }
        public bool Success { get; set; } = false;
        public string ErrorMessage { get; set; }
	}
}

