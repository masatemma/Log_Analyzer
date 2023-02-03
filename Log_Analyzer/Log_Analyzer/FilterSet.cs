using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Analyzer
{
    internal class FilterSet
    {
        public List<FilterProperty> filterProperties { get; set; }
        public int filterNum = 0;
        
        public FilterSet(int filterNum)
        {
            
            this.filterProperties = new List<FilterProperty>
            {
                new FilterProperty(),
                new FilterProperty(),
                new FilterProperty()
            };
            
            this.filterNum = filterNum;
        }

        public void clearFilterSet()
        {
            for(int i = 0; i < 3; i++)
            {
                this.filterProperties[i].filterText = "";
            }
            filterNum= 0;
            
        }

    }
}
