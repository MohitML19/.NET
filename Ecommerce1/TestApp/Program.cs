using BOL;
using DAL;
using DLL;
List<Department> list = DBManager.allDepartments();

foreach (Department dept in list)
{
    Console.WriteLine(dept.Name + " " + dept.Location);
}
Console.WriteLine("----------------------------------------------------");

Department d1 = DBManager.getDepartment(1);
Console.WriteLine(d1.Name + " " + d1.Location);

Console.WriteLine("-----------------------------------------------------");
Department d2 = new Department("RnD","Satara");
bool b = DBManager.insertDept(d2);
Console.WriteLine(b);