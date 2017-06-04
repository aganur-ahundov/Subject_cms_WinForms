using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace subject_cms.Models
{
    public class FileContainer
    {
        public FileInfo file;

        public string Title { get; set; }

        //Is it for public access
        public bool IsAvailable { get; set; }

        public string Description { get; set; }
    }
}
