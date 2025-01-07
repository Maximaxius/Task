import React from 'react';

function PersonInfo(props) {
    let {name} = props;
    return (
        <div>
            {name}
        </div>
    );
   }

export default PersonInfo;