using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syap2
{
    class StudentsList
    {
        List<bool> search;
        public List<Student> students;
        public int curSt, first, last;
        public StudentsList()
        {
            students = new List<Student>();
            search = new List<bool>();
            curSt = -1;
        }
        public void NewStudent(Student st)
        {
            students.Add(st);
            curSt = students.Count - 1;
            search.Add(true);
            if (first == -1)
                first++;
            last++;
        }
        public void NewInfo(string name, string surname, string faculty)
        {
            students[curSt].name = name;
            students[curSt].surname = surname;
            students[curSt].faculty = faculty;
        }
        public void NewInfo(string name, string surname, string faculty, string diploma)
        {
            Master ms = new Master(name, surname, faculty, diploma);
            students[curSt] = ms;
        }
        public void Prev()
        {
            if (curSt <= 0)
                return;
            curSt--;
            while (!search[curSt])
                curSt--;
        }
        public void Next()
        {
            if (curSt >= search.Count - 1)
                return;
            curSt++;
            while (!search[curSt] )
                curSt++;
        }
        public void Delete()
        {
            if (curSt < 0)
                return;
            students.RemoveAt(curSt);
            search.RemoveAt(curSt);
            first = 0;
            while (first <= search.Count - 1 && !search[first])
                first++;
            last = students.Count - 1;
            while (last >= 0 && !search[last])
                last--;
            if (last < 0)
            {
                curSt = -1;
                first = -1;
                last = -1;
                return;
            }
            if (curSt > first)
                Prev();
            else
                curSt = first;
        }
        public void NewList()
        {
            students.Clear();
            search.Clear();
            curSt = -1;
            first = -1;
            last = -1;
        }
        public void Upgrade()
        {
            Master ms = new Master();
            students[curSt] = ms;
        }
        public void SearchDefault()
        {
            if (students.Count == 0)
            {
                curSt = -1;
                first = -1;
                last = -1;
                return;
            }
            curSt = 0;
            first = 0;
            search.Clear();
            for (int i = 0; i < students.Count; i++)
                search.Add(true);
            last = students.Count - 1;
        }
        public void Search(Func<Student,bool> check)
        {

            for (int i = 0; i < search.Count; i++)
                if (check(students[i]))
                    search[i] = false;
            curSt = 0;
            while (curSt < students.Count && !search[curSt])
                curSt++;
            first = curSt;
            last = students.Count - 1;
            while (last >= 0 && !search[last])
                last--;
        }
    }
}
