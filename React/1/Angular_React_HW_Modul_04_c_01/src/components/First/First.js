import React from 'react';

// Создайте и запустите приложение React, выводящее информацию о вашей любимой книге в браузер. 
// Например: название книги, ФИО автора, жанр книги, количество страниц, несколько рецензий на неё.

function First(props) {

    let { bookName, author, genre, pages } = props;

    return (
        <div>
            bookName={bookName}, author={author}, genre {genre}, pages {pages}
        </div>
    );
}

export default First;

First.defaultProps = { bookName: "how to learn cc+", author: "Anton", genre: "Info", pages: "1355" };