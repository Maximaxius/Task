import React from "react";

// Создайте и запустите приложение React, выводящее
// краткую информацию о вас в браузер. Например: ФИО,
// контактный телефон, электронный адрес.

function First(props) {

    let { firstName, lastName, phone, mail } = props;   

    return(
        <div>
            firstName={firstName}, lastName={lastName}, phone {phone}, mail {mail}
        </div>
    );
}

export default First;

First.defaultProps = {firstName: "First name", lastName: "Last name", phone: "+123456789",mail: "Mail@.com"};