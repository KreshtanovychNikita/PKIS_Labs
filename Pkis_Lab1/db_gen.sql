CREATE TABLE [Person] (
  Id integer NOT NULL IDENTITY (1, 1),
  Firstname varchar(30) NOT NULL,
  MIddlename varchar(30),
  Lastname varchar(30) NOT NULL,
  PRIMARY KEY (Id)
)
GO
CREATE TABLE [Company] (
  Id integer NOT NULL IDENTITY (1, 1),
  CompanyName varchar(15) NOT NULL,
  PhoneCompanyNumber varchar(15) NOT NULL,
  AddresCompany varchar(30) NOT NULL,
  PRIMARY KEY (Id)
)
GO
CREATE TABLE [Goods] (
  Id integer NOT NULL IDENTITY (1, 1),
  GoodsName varchar(20) NOT NULL,
  CompanyId integer NOT NULL,
  CalculateV varchar(20) NOT NULL,
  QuantityOfGoods integer (1000) NOT NULL,
  SaleTime datetime NOT NULL,
  Discount integer (20),
  Price float NOT NULL,
  Description varchar(250),
  PRIMARY KEY (Id),
  FOREIGN KEY (CompanyId) REFERENCES Company(Id)
)


