let parents = document.getElementsByClassName("schema-product schema-product_narrow-sizes")

parents = Array.from(parents)

let res ="";
for (el in parents) {
  
  parent = parents[el];
  elName = parent.getElementsByClassName("schema-product__title");
  elName = elName[0].getElementsByTagName("a");  
  let name = elName[0].getElementsByTagName("span")[0].innerText;
  let link = elName[0].href;

  // rev = parent.getElementsByClassName("schema-product__review-count");
  // rev = elName[0].getElementsByTagName("span")[0].innerText;
  // console.log(rev[0].innerText)

  price = parent.querySelector(".schema-product__price").innerText;

  info = parent.querySelector(".schema-product__description").innerText;

  res += `${name}, ${link} , ${price} ,${info}\n`;
}
console.log(res)