# Prog_122_L5_Notes_Week3
Classes continued
UML=Unified Modeling Language
Mehtod signitures can't be the same
method overload allowed with different parameters type
constructor has to have the same name at the class
fields should be private
getters give permission to show fields
if only getter it is read only
setters giver permision to change to fields value
```xaml.cs
for(int i = 0; order1.Products.Count > i; i++)
            {
                
                Product product = order1.Products[i];
                if(product.Title.Contains("El Dordado"))
                {
                    order1.Products.Remove(product);
                }
             }
```
```xaml.cs
for(int i = 0; order1.Products.Count > i; i++)
            {
                if (order1.Products[i].Title.Contains("Robcop"))
                {
                    order1.Products.Remove(order1.Products[i]);
                }
            }
```