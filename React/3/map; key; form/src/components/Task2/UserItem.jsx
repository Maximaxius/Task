import React from "react";

const ListItem = ({ name, lastName,age,email }) => {
  return (
    <>
      <div style={{ borderBottom: "2px dotted", padding: "7px" }}>
       {name} {lastName} {age} {email}
      </div>
    </>
  );
};

export default ListItem;