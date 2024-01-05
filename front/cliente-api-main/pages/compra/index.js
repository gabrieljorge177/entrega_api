import "bootstrap/dist/css/bootstrap.css";
import { useEffect, useState } from "react";
import axios from "axios";
import style from "../../styles/Home.module.css";
import Link from "next/link"; // Importe o Link para criar links de navegação

const Home = () => {
  const [clients, setClients] = useState([]);

  useEffect(() => {
    // Faça uma chamada GET para a API Spring Boot
    axios
      .get("https://localhost:7065/api/Compras")
      .then((response) => {
        setClients(response.data);
      })
      .catch((error) => {
        console.error("Erro ao buscar a lista de compras:", error);
      });
  }, []);

  return (
    <div>
      <h1 className={style.h1}>Lista de Compras</h1>
      <p>
        <Link href="categoria/add-client" style={{ backgroundColor: "green" , color:'white', textDecoration:'none'}}>
          Realizar Nova Compra
        </Link>
      </p>
      <table className="table container tabela">
        <thead>
          <tr>
            <th>Id_Compra</th>
            <th>Data da compra</th>
            <th>Metodo de Pagamento</th>
            <th>Preço da Compra</th>
            <th>Nome do Cliente</th>
            <th>Cidade de destino</th>
            <th>Ações</th>{" "}
            {/* Adicione uma coluna para as ações de edição e exclusão */}
          </tr>
        </thead>
        {clients.map((element) => (
          <tbody key={element.id_Compra}>
            <tr className={style.tabela}>
              <td>{element.id_Compra}</td>
              <td>{element.data_Compra}</td>
              <td>{element.metodo_Pagamento}</td>
              <td>{element.preco_Compra}</td>
              <td>{element.clientes.nome}</td>
              <td>{element.passagens.cidade}</td>
              <td>
                <Link
                  href={`categoria/update-client/${element.id_Compra}`}
                  className="btn btn-warning"
                >
                  Editar
                </Link>
                <Link
                  href={`categoria/delete-client/${element.id_Compra}`}
                  className="btn btn btn-danger"
                >
                  Excluir
                </Link>
              </td>
            </tr>
          </tbody>
        ))}
      </table>
    </div>
  );
};

export default Home;
