import ProductList from "./ProductList";
import { useFetchProductsQuery } from "./catalogApi";

export default function Catalog() {
  const { data, isLoading } = useFetchProductsQuery();

  console.log(data)

  if(isLoading || !data) return <h3>Loading...</h3>

  return (
    <>
      <ProductList products={data} />
    </>
  )
}
