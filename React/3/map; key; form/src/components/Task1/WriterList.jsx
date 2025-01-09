import React from "react";
import ListItem from "./ListItem";


const WritersList = ({ data }) => {
  return (
    <div>
      {data.map((item, index) => (
        <ListItem key={`${index}`} {...item} />
      ))}
    </div>
  );
}

WritersList.defaultProps = { data: [] };
export default WritersList;