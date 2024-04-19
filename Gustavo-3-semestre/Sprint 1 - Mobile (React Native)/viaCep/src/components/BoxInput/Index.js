import { Input } from "../Input/Index"
import { Label } from "../Label/Index"
import { FieldContent } from "./style"

export const BoxInput = ({
    fieldWidth = 100,
    editable = false,
    textLabel,
    placeholder,
    fieldvalue = null,
    onChangeText = null,
    keyType = 'default',
    maxLength
}) => {
    return (
        <FieldContent fieldWidth={fieldWidth}>
            <Label textLabel={textLabel} />

            <Input
                editable={editable}
                placeholder={placeholder}
                keytype={keyType}
                maxlength={maxLength}
                fieldvalue={fieldvalue}
                onChangeText={onChangeText}
            />
        </FieldContent>

    )
}