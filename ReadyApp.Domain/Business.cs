using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    internal class Business
    {
        public int BusinessId { get; private set; }
        public string Name {  get; private set; }
        public string Description {  get; private set; }
        public string Type {  get; private set; }
        public string Username { get; set; }
        // Constructor instances
        public Business() { }
        /// <summary>
        /// Create a instance of a business object.
        /// </summary>
        /// <param name="name">Sets name of business</param>
        /// <param name="description">Sets description of business</param>
        public Business(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
