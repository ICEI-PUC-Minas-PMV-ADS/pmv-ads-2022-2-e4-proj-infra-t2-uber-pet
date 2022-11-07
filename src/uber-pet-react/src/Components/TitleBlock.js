import React from 'react';

import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

export default function TitleBlock({title,icon})
{
  return (
    <div className="flex flex-row">
        <div className="text-xl font-bold w-auto p-2 ml-8 px-4">
          <span>{title}&nbsp;<FontAwesomeIcon icon={icon}/></span>
        </div>
      </div>
  )
}