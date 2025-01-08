import React from 'react';
import ReactDOM from 'react-dom/client';      //VirtualDOM
import './index.css';                         
import App from './components/App/App';                      //подключение пользовательского компонента App
import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));    //создаём новый контейнер
root.render(                                                          //внутри которого будем отображать компонент App
  <React.StrictMode>                                                    
    <App /> 
    {/* <App />                                                           */}
  </React.StrictMode>                                                 
);


// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
