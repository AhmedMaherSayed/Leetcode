Select p.product_name, S.year, S.price
From Sales as S, Product as P
Where P.product_id = S.product_id;