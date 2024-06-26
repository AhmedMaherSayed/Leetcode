/* Write your T-SQL query statement below */

SELECT E.name AS Employee
FROM Employee E, Employee M
WHERE M.id = E.managerId AND M.salary < E.salary;