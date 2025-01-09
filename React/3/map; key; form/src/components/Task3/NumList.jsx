import React from "react";
import NumItem from "./NumItem";


const NumList = ({ data }) => {
  return (
    <div style={{display: "flex",flexWrap: "wrap"}}>
      {data.map((item, index) => (
        <NumItem key={`${index}`} {...item} />
      ))}
    </div>
  );
}

NumList.defaultProps = { data: [] };
export default NumList;