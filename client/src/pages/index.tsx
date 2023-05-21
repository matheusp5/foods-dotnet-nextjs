import axios from 'axios';
import https from 'https';
import Food from "@/components/Food";

export async function getServerSideProps() {

  const agent = new https.Agent({
    rejectUnauthorized: false
  });
  const api = axios.create({
    baseURL: 'http://localhost:12619/foods',
    httpsAgent: agent
  });
  const {data} = await api.get("/getAll")
  return {
    props: {
      foods: data
    }
  }
}


export default function Home({foods = []}: any) {
  return (
      <>
        <h1 className="text-5xl font-bold ml-12 mb-5">Comidas</h1>
        {foods.map((e: any, i: number) => <Food food={e}/>)} 
      </>
  )
}
