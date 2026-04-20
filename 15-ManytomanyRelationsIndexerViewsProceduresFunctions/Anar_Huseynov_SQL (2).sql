create database CompanyMM
use CompanyMM

create table Employes (
    EmployeeID int primary key identity(1,1),
    FirstName nvarchar(50) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    BirthDate date,
    Email nvarchar(100) unique NOT NULL,
    constraint CHK_BirthDate check (BirthDate > '1950-01-01')
)


create table Projects (
    ProjectID int primary key identity(1,1),
    ProjectName nvarchar(100) NOT NULL,
    StartDate date NOT NULL,
    EndDate date,
    constraint CHK_Dates check (EndDate IS NULL OR EndDate >= StartDate)
)

create table EmployeeProjects (
    EmployeeID int,
    ProjectID int,
    AssignedDate date default getdate(),
    primary key (EmployeeID, ProjectID),
    foreign key (EmployeeID) references Employes(EmployeeID) on delete cascade,
    foreign key (ProjectID) references Projects(ProjectID) on delete cascade
)

insert into Employes (FirstName, LastName, BirthDate, Email) values
('Anar', 'Huseynov', '2006-04-18', 'anar@company.com'),
('Ilkin', 'Omarov', '2005-07-01', 'ilkin@company.com'),
('Huseyn', 'Rzayev', '1999-09-11', 'huseyn@company.com'),
('Nigar', 'Seyidli', '2007-10-15', 'nigar@company.com'),
('Mehdi', 'Qurbanov', '1983-02-27', 'mehdi@company.com')


insert into Projects (ProjectName, StartDate, EndDate) values
('E-Commerce Site', '2024-01-01', '2024-06-30'),
('Mobile App', '2024-02-15', '2024-12-01'),
('Cloud Migration', '2024-03-01', NULL)

insert into EmployeeProjects (EmployeeID, ProjectID) values
(1, 1), (1, 2), (1, 3), 
(2, 1), 
(3, 2), 
(4, 3), 
(5, 3)

select * from Employes 

select * from Projects

select e.FirstName, e.LastName, p.ProjectName from Employes as e
join EmployeeProjects as ep 
on e.EmployeeID = ep.EmployeeID
join Projects as p
on ep.ProjectID = p.ProjectID

select p.ProjectName, count(ep.EmployeeID) as EmployeeCount from Projects as p
left join EmployeeProjects as ep on p.ProjectID = ep.ProjectID
group by p.ProjectName

select e.FirstName, e.LastName, count(ep.ProjectID) as TotalProjects from Employes as e
join EmployeeProjects as ep on e.EmployeeID = ep.EmployeeID
group by e.EmployeeID, e.FirstName, e.LastName
having count(ep.ProjectID) > 2



create view EmployeeProjectView as
Select 
    e.EmployeeID, 
    (e.FirstName + ' ' + e.LastName) as FullName, 
    p.ProjectID, 
    p.ProjectName, 
    ep.AssignedDate
from Employes as e
join EmployeeProjects as ep on e.EmployeeID = ep.EmployeeID
join Projects as p on ep.ProjectID = p.ProjectID


select * from EmployeeProjectView  where EmployeeID = 1

create procedure usp_AssignEmployeeToProject 
    @empId int, 
    @projId int
as
begin
    if not exists (select 1 from EmployeeProjects where EmployeeID = @empId and ProjectID = @projId)
    begin
        insert into EmployeeProjects (EmployeeID, ProjectID) values (@empId, @projId);
    end
end

create function fn_GetProjectCount(@empId int) returns int as
begin
    declare @p_count int;
    select @p_count = count(*) from EmployeeProjects where EmployeeID = @empId;
    return @p_count;
end

select FirstName, LastName, dbo.fn_GetProjectCount(EmployeeID) as TotalProjects from Employes

exec usp_AssignEmployeeToProject @empId = 2, @projId = 2

delete from EmployeeProjects where EmployeeID = 5

select * from EmployeeProjectView

