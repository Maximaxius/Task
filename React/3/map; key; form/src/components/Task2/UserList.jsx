import React from "react";
import UserItem from "./UserItem";


const UserList = ({ data }) => {
  return (
    <div>
      {data.map((item, index) => (
        <UserItem key={`${index}`} {...item} />
      ))}
    </div>
  );
}

UserList.defaultProps = { data: [] };
export default UserList;