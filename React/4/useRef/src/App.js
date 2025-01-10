import './App.css';
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

import Students from "./components/students.jsx";
import News from "./components/news.jsx";
import Menu from "./components/menu.jsx";
import Stories from "./components/stories.jsx";


const App = () => {

  return (
    <Router>
      <Menu />
      <Routes>
        <Route exact path="/students" element={<Students />}/>
        <Route exact path="/news" element={<News />}/>
        <Route exact path="/stories" element={<Stories />}/>
      </Routes>
    </Router>

  );
}

export default App;
