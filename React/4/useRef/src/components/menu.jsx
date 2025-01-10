import React from "react";
import { Link } from "react-router-dom";

const Menu = () => {
    return (
        <nav>
        <ul>
          <li>
            <Link className="link" to="/students">
              Студенты
            </Link>
          </li>
          <li>
            <Link className="link" to="/news">
              Новости
            </Link>
          </li>
          <li>
            <Link className="link" to="/stories">
              Сторис
            </Link>
          </li>
        </ul>
      </nav>
    )
}

export default Menu;