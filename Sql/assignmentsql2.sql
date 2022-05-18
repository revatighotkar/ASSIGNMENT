
select * from tblDepartment

select * from tblemployee

--1. Retrieve a list of Managers.
select * from tblemployee where Job ='MANAGER';

--2. Find out salary of both MILLER and SMITH.
select Ename, Sal from tblemployee WHERE Ename in ('SMITH','MILLER')

--3. Find out the names and salaries of all employees earning more than 1000 per MONTH
Select Ename,Sal FROM tblemployee WHERE Sal>1000;

--4. Display the names and salaries of all employees except JAMES.
Select Ename,Sal From tblemployee Where Ename !='JAMES'

--5. Find out the details of employees whose names begin with ‘S’.
Select * From tblemployee Where Ename LIKE 'S%';

--6. Find out the names of all employees that have ‘A’ anywhere in their name.
Select * From tblemployee Where Ename LIKE '%A%';

--7. Find out the names of all employees that have ‘L’ as their third character in their name.
Select Ename From tblemployee Where Ename LIKE '__L%'

--8. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
 Select Ename From tblemployee Where Ename LIKE 'A%' OR Ename LIKE 'M%';

--9. Compute yearly salary of SMITH.
Select (Sal*12) as 'Annual salary' from tblemployee Where Ename = 'SMITH';

--10. Compute daily salary of JONES.
Select Sal/30 'JONES DAILY SAL' From tblemployee Where Ename='JONES';

--11. Calculate the total monthly salary of all employees.
Select sum(Sal) as 'TOTAL SAL' From tblemployee

--12. Print the average annual salary.
  Select AVG(Sal*12) as'AVG ANNUAL SAL' from tblemployee;

--13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
Select Ename,Job,Sal,Deptno From tblemployee Where Job!='SALESMAN' AND Deptno=30;


--14. List unique departments of the EMP table.
Select Deptno From tblemployee Group by Deptno;


--15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30.
-- Label the columns Employee and Monthly Salary respectively.
Select Ename as'EMPLOYE',Sal as 'MONTHLY SALARY' From tblemployee Where Sal>1500 AND Deptno IN (10,30);