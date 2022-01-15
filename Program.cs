// See https://aka.ms/new-console-template for more information

using EmployeeWage;


Console.WriteLine("Hello, World!");

EmpPresentOrNot emp = new EmpPresentOrNot();
emp.IffElse();

FullTime flt = new FullTime();
flt.EmployeFullTime();

PartTime prt = new PartTime();
prt.EmployePartTime();

EmpSwitch empswtch = new EmpSwitch();
empswtch.Employe();

EmpForLoop emploop = new EmpForLoop();
emploop.Employeee();


EmpWhile empwhile = new EmpWhile();
empwhile.Employeeee();