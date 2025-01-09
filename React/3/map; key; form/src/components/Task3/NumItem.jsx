import React from "react";

const NumItem = ({num,color}) => {

  return (
    <>
    <div style={{ padding: `${num}px`,backgroundColor: `${color}`,
    height: `${num>=25 ? num+'px': '25px'}`,
    width: `${num>=25 ? num+'px': '25px'}`,
    margin: "10px",
    borderRadius: "15px"}}>
       {num} 
    </div>
    </>
  );
};

export default NumItem;
