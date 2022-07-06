create table products (
                          id int unsigned auto_increment primary key,
                          name varchar(20)
);

create table categories (
                            id int unsigned auto_increment primary key,
                            name varchar(20)
);

create table prod_cat (
                          id int unsigned auto_increment primary key,
                          productId int unsigned,
                          categoryId int unsigned,
                          FOREIGN KEY (productId) REFERENCES products(id),
                          FOREIGN KEY (categoryId) REFERENCES categories(id)
);

select p.name, c.name from products as p
                               left outer join prod_cat as pc on p.id = pc.productId
                               left outer join categories as c on pc.categoryId = c.id;