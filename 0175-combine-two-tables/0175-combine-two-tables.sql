/* Write your T-SQL query statement below */

Select firstName, lastName, city, state
From Person as P left join Address as A
on P.personId = A.personId;