using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DB.Models
{
    /// <summary>
    /// DB Entity Class
    /// </summary>
    public class Agent
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentCity { get; set; }
    }
}
