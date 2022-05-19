
--ASSIGNMENT3--


select * from tblEmployee


--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select Ename, Sal from tblEmployee where sal not between 1500 and 2850;

--2. Display the name and job of all employees who do not have a MANAGER. 
select Ename, Job from tblEmployee where MGR_Id is null;

--3. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select Ename,Job,Sal from tblEmployee where Job in('MANAGER','ANALYST') and sal not in(1000,3000,5000);

--4. Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%. 
select Ename,Sal,Comm from tblEmployee where Comm > Sal+Sal*.10;

--5. Display the name of all employees who have two( LS )in their name and are in 
--department 30 or their manager is 7782. 
 select Ename from tblEmployee where Ename like '%LL%' and deptno in (30) or MGR_id =7782;

 --6. Display the names of employees with experience of over 10 years and under 20 yrs.
 --Count the total number of employees. 
 update tblEmployee set HireDate='28-SEP-10' where Empno in(7654,7900);


 SELECT COUNT(hireDate) AS 'NO_OF_EMPLOYEES',Ename
 FROM tblEmployee
 WHERE CONVERT(varchar(3),DATEDIFF(YEAR, HireDate, GETDATE()))>10
 AND CONVERT(varchar(3),DATEDIFF(YEAR, HireDate, GETDATE()))<20
 GROUP BY Ename

 SELECT * FROM tblDepartment


 --7. Retrieve the names of departments in ascending order and their employees in descending order.
 select DName,Ename from tblDepartment join tblEmployee on tblDepartment.deptNo = tblEmployee.deptno
 order by DName asc , ename desc

 --8. Find out experience of MILLER. 
select convert(varchar(5),datediff(year,hiredate,getdate())) as'Experience'
from tblEmployee where Ename='MILLER'

 --9. How many different departments are there in the employee table. 
 select Dname,count(*) as 'No of Departments' from tblEmployee join tblDepartment on
 tblDepartment.Deptno= tblEmployee.Deptno
 group by Dname

 --10. Find out which employee either work in SALES or RESEARCH department. 
 select Ename,  Dname from tblEmployee join tblDepartment on tblEmployee.Deptno= tblDepartment.Deptno 
 where Dname in('SALES','RESEARCH')

 --11. Print the name and average salary of each department. 
 select Dname, avg(Sal) as 'Average Salary' from tblEmployee  join tblDepartment 
  on tblEmployee.Deptno=tblDepartment .Deptno
 group by Dname

 --12. Select the minimum and maximum salary from employee table. 
 select min(Sal) as 'minimum salary', max(Sal) as 'maximumsalary' from tblEmployee

 --13. Select the minimum and maximum salaries from each department in employee table.
 select Dname,min(Sal) as 'minimum_salary',max(Sal) as 'maximum_salary' from TBLEmployee join tblDepartment
 on tblEmployee.deptno= tblDepartment.DeptNo 
 group by Dname 

 --14. Select the details of employees whose salary is below 1000 and job is CLERK. 
 select * from tblEmployee where sal<1000 and Job in ('CLERK')

