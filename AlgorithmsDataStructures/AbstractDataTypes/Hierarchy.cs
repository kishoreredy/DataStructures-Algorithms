using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.AbstractDataTypes
{
    /*
     * Collections can be considered as Abstract Data Types
     * like Stack (it holds data in form of properties 
     * and manipulation of data will happen with methods inside it.
     * Pop -> for removing the data
     * Push -> for inserting the data
     * Clear -> for clearing the data)
     * 
     * Similarly, this Hierarchy is an Abstract Data Type class.
     * It has data like Id, Name, Experience, IsLeaf, HasChildren
     * IsHierarchy is method to manipulate above data.
     *
     */
    internal class Hierarchy
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Experience { get; set; }
        public bool IsLeaf { get; set; }
        public bool HasChildren { get; set; }
        public bool IsHierarchy() => true;
    }
}
