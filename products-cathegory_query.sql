SELECT product.ID, product.Name, cathegory.Name
  FROM products
LEFT OUTER JOIN product_cathegories
  ON product.ID = product_cathegories.Product_Id
LEFT OUTER JOIN cathegory
  ON group_elements.Cathegory_id = cathegory.ID