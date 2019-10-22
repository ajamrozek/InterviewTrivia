using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTrivia.BlazorApp.p9.Data
{
    public class BTreeModel
    {

        [Required]
        public string InString { get; set; }

        public IEnumerable<NodeElement> NodeElements {get;set;} 
    }

    public class NodeElement
    {
        public int Value { get; set; }
        public string PositionStyle { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public int ParentValue { get; set; }
    }
}
