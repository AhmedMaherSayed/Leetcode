/* Write your T-SQL query statement below */
SELECT DISTINCT P.email
FROM Person P, Person E
WHERE P.email = E.email AND P.id != E.id;