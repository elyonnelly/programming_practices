using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_TODOTasks_ClassLibrary
{
    public class Rate
    {
        /// <summary>
        /// Количество попаданий
        /// </summary>
        public uint Hits { get; set; }
        /// <summary>
        /// Количество промахов
        /// </summary>
        public uint Fails { get; set; }

    }
}
