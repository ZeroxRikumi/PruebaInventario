/*==============================================================*/
/* Table: PRODUCTO                                             */
/*==============================================================*/
create table PRODUCTO (
   ID         			SERIAL               not null,
   CODIGO        		CHAR(10)             not null,
   NOMBRE		        VARCHAR(25)          not null,
   DESCRIPCION	        VARCHAR(50)          not null,
   PRECIO		        INT			         not null,
   STOCK				INT					 not null,
   CATEGORIAID			INT					 not null,
   constraint PK_PRODUCTO primary key (ID)
);

/*==============================================================*/
/* Table: CATEGORIA                                             */
/*==============================================================*/
create table CATEGORIA (
   ID         			SERIAL               not null,
   NOMBRE		        VARCHAR(25)          not null,
   DESCRIPCION	        VARCHAR(50)          not null,
   constraint PK_CATEGORIA primary key (ID)
);

alter table PRODUCTO
   add constraint FK_PRODUCTO_PERTENECE_CATEGORIA foreign key (CATEGORIAID)
      references CATEGORIA (ID)
      on delete restrict on update restrict;

     
     
INSERT INTO public.categoria (nombre, descripcion) VALUES('Herramientas', 'productos para maniobrar mano de obra');
INSERT INTO public.categoria (nombre, descripcion) VALUES('Juguetes', 'productos para los menores');
INSERT INTO public.categoria (nombre, descripcion) VALUES('Carpinteria', 'productos hechos en base a madera');

INSERT INTO public.producto (codigo, nombre, descripcion, precio, stock, categoriaid) VALUES('C0111364  ', 'Plancha de Madera', 'Plancha para construcciones en base a madera', 30000, 5, 3);
INSERT INTO public.producto (codigo, nombre, descripcion, precio, stock, categoriaid) VALUES('C0112355  ', 'Pelota de Futbol pequeña', 'Pelota de Futbol para niños pequeños', 5000, 3, 2);
INSERT INTO public.producto (codigo, nombre, descripcion, precio, stock, categoriaid) VALUES('C0200500  ', 'Martillo Electrico', 'Ideal para obras que requiere fuerza mecanica', 90000, 4, 1);
INSERT INTO public.producto (codigo, nombre, descripcion, precio, stock, categoriaid) VALUES('C0200502  ', 'Sierra Electrica', 'Sierra Electrica para efectuar cortes precisos', 75000, 2, 1);