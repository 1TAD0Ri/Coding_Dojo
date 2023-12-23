import React from 'react';

const BoxDisplay = ({ boxs }) => {
    console.log(boxs);

    return (
        <div>
            {boxs.map((element) => (
                <div style={{ backgroundColor: `${element}`, width: "100px", height: "100px" , marginTop: "20px" }}>
                    
                </div>
            ))}
        </div>
    );
};

export default BoxDisplay;
