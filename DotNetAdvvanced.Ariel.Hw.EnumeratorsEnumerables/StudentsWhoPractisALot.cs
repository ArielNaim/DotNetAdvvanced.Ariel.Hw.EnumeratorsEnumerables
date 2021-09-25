using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvvanced.Ariel.Hw.EnumeratorsEnumerables
{
   public class StudentsWhoPractisALot : Enum 
    {
        public int Grade { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        List<StudentsWhoPractisALot> studentGrade = new List<StudentsWhoPractisALot>();
        List<StudentsWhoPractisALot> greadBiggerThenTen = new List<StudentsWhoPractisALot>();
        
        public StudentsWhoPractisALot(int grede, int id, string name)
        {
            Grade = grede;
            Id = id;
            Name = name;
        }
        public List<StudentsWhoPractisALot> GetOutstandingStudent()
        {
            foreach (var itam in studentGrade)
            {
                if (Grade > 10)
                {
                    greadBiggerThenTen.Add(itam);
                }
                return greadBiggerThenTen;
            }
            return null;
        }
    }
}
