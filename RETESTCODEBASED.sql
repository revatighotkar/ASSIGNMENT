create database Retest
use Retest



create table PRODUCT(ProductId int Primary key,
ProductName varchar(40),
Price int,
QtyAvailable int)


 

select * from PRODUCT






create or alter proc PRODUCT_delete
as
begin
begin try

delete from PRODUCT where productid=106
end try
begin catch
print 'Select the matched product'
end catch

end




exec PRODUCT_delete

