/*NEW COLUMN TO MANAGE USER APPS PASSWORD*/
ALTER TABLE VTMCLH
ADD USR_VTMCLH_CONAPP VARCHAR(250);

UPDATE VTMCLH SET USR_VTMCLH_CONAPP = 'EG+Vl+Cy6owb1Tm1UHYJIZgOYePv/B8kauOdzCQFv8LzSkSUDvhLg3wj1BnP0Ha9FsZ5eghKVMCVmmmu2ji+0IjznNA=' 
WHERE LEFT(VTMCLH_NROCTA,2) = 'ZI'


select  * from VMRMVH 
select * from VTRMVH where VTRMVH_VNDDOR = 'IN0026' order by 3 desc
select top 100 * from VTRMVI where VTRMVI_NROFOR = 91315

select * from VMRMVH where VMRMVH_NROFOR = 91315

select * from VTRMVH where VTRMVH_NROFOR = 91315
select * from VTRMVI where VTRMVI_NROFOR = 91315


/*Clientes*/
select * from VTMCLH where  VTMCLH_COBRAD = 'IN0026' order by VTMCLH_NROSUB
select * from VTMCLH where VTMCLH_COBRAD <> ''
select * from VTMCLH where LEFT(VTMCLH_NROCTA,6) = 'VH7172'
/*Vendedores*/
	select * from VTTVND where VTTVND_VNDDOR = 'IN0026'
	select * from VTMCLH where VTMCLH_COBRAD = 'IN0026'--VTMCLH_NROCTA = 'ZI0026'
/*PREVENT*/
select * from VTMCLH where LEFT(VTMCLH_NROCTA,6) = 'VH7172'
	select STMPDH_INDCOD,* from STMPDH where STMPDH_TIPPRO = 'MIPR30'  and STMPDH_ARTCOD = 'HCA3050P' order by 1
	select FCRMVH_VNDDOR,FCRMVH_FCHDES,FCRMVH_FCHHAS,* from FCRMVH where FCRMVH_NROFOR = 92197 and FCRMVH_CODFOR = 'PREVEN'
select FCRMVI_FECALT,FCRMVI_USERID,* from FCRMVI where FCRMVI_NROFOR = 92197 and FCRMVI_CODFOR = 'PREVEN'

select top(100) * from FCRMVH where FCRMVH_MODFOR = 'FC' and FCRMVH_CODFOR = 'PREVEN' order by FCRMVH_NROFOR desc
select top(100) FCRMVI_FECALT,FCRMVI_USERID,* from FCRMVI where FCRMVI_MODFOR = 'FC' and FCRMVI_CODFOR = 'PREVEN' order by FCRMVI_NROFOR desc
/*Productos*/
select STMPDH_INDCOD, STMPDH_UNICON, * from STMPDH where STMPDH_TIPPRO = 'MIPR30'  and STMPDH_ARTCOD = 'HCA3050P' order by 1
/*Tipo Productos*/
select * from STTTPH

select STTPRE_CODLIS,P.STMPDH_ARTCOD,P.STMPDH_TIPPRO,L.STTPRE_TIPPRO, l.STTPRE_ARTCOD, P.STMPDH_DESCRP,
STMPDH_INDCOD,L.STTPRE_PRECIO,STMPDH_UNIMED,l.STTPRE_FECLIS,* from STMPDH P
join STTPRE L
on p.STMPDH_ARTCOD = l.STTPRE_ARTCOD
where p.STMPDH_INDCOD <> '' AND STTPRE_PRECIO > 0
--and STTPRE_ARTCOD = 'HCA3050P' 
--AND STTPRE_CODLIS = 'LPMIMO0001'
--and STTPRE_OLDUID = 'ADMIN'
and P.STMPDH_TIPPRO like 'MI%'
and p.STMPDH_INDCOD = '2'
order by l.STTPRE_FECLIS desc

	select distinct STTPRE_ARTCOD,* from STTPRE where STTPRE_ARTCOD = 'HCA3050P' 
	--AND STTPRE_CODLIS = 'LPMIIN0001'
	--and STTPRE_PRECIO = 510
	order by STTPRE_FECLIS desc--'HEL4050P'
	select * from STTPRE
	select * from TSTPRH-- where STTPRO_ARTCOD = 'HEL4050P'
	

select * from VTRMVI-- order by 3 desc--VTRMVH--VTTVND
where VMRMVH_NROFOR like '%91882%'