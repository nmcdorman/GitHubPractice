import csharp

from MethodCall call, Method add
where
  call.getTarget() = add.getAnUltimateImplementor*() and
  add.hasName("Add") and
  add.getDeclaringType()
      .getUnboundDeclaration()
      .hasQualifiedName("System.Collections.Generic.ICollection<>") and
  call.getAnArgument() instanceof NullLiteral
select call
