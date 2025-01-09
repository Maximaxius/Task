import React from "react";
import ReactDOM from "react-dom/client"; //VirtualDOM
import "./index.css";
import App from "./components/App/App"; //подключение пользовательского компонента App

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  // <React.StrictMode>
  //   <App />
  // </React.StrictMode>
  <App />
);

// StrictMode выполняет рендеринг компонентов дважды в development режиме, но не в production. По мнению разработчиков React - это позволяет обнаружить некоторые проблемы в вашем коде, если таковые будут и предупредить Вас об этом

// не баг, а фича =)
