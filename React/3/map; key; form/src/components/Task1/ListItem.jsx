import React from "react";

const ListItem = ({ name, lastName }) => {
  return (
    <>
      <div style={{ borderBottom: "2px dotted", padding: "7px" }}>
       {name} {lastName}
      </div>
    </>
  );
};

export default ListItem;