SELECT  EmpUni.unique_id,  Emp.name
FROM Employees as Emp left join EmployeeUNI as EmpUni
ON Emp.id = EmpUni.id;